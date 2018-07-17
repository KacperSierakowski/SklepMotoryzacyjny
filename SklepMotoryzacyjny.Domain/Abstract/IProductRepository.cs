using System.Collections.Generic;
using SklepMotoryzacyjny.Domain.Entities;

namespace SklepMotoryzacyjny.Domain.Abstract
{
    public interface IProductRepository
    {
      // interfejs IEnumerable<T>, który pozwala na pozyskanie sekwencji
      //  obiektów Product bez konieczności określania sposobu przechowywania i pobierania danych.
                IEnumerable<Product> Products { get; }
    }
}