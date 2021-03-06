using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1, ColorName = "Beyaz"},
                new Color{ColorId=2, ColorName = "Mavi"},
                new Color{ColorId=3, ColorName = "Kirmizi"},
                new Color{ ColorId = 4, ColorName = "Gri"},
                new Color{ ColorId = 5, ColorName = "Siyah"},
            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);

            _colors.Remove(colorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return _colors.Where(c => c.ColorId > 0).SingleOrDefault();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colors;
        }

        public void Update(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToDelete.ColorId = color.ColorId;
        }
    }
}