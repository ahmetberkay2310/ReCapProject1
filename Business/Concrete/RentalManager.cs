using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.RentalNullDate);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
        }

        public IResult Delete(Rental rental)
        {
            var rentalDeleted = _rentalDal.Get(p => p.Id == rental.Id);
            if (rentalDeleted != null)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.RentalDeleted);
            }
            else
            {
                return new SuccessResult(Messages.RentalNotFound);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {

            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalList);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id));
        }

        public IResult Update(Rental rental)
        {
            var rentalUpdated = _rentalDal.Get(p => p.Id == rental.Id);

            if (rentalUpdated != null)
            {
                _rentalDal.Update(rental);
                return new SuccessResult(Messages.RentalUpdated);
            }
            else
            {
                return new SuccessResult(Messages.RentalNotFound);
            }
        }
    }
}