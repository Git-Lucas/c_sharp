using PrimeiroProjeto.EntitiesProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesProduct.Services
{
    class ProductService
    {
        //Método que fará a soma dos itens de uma lista de Products, a partir de um critério
        public double FilteredSum(List<Product> products, Func<Product, bool> criteria)
        {
            double sum = 0;

            //Percorre toda a lista
            foreach (Product p in products)
            {
                //O criteria é o parâmetro do método, que neste momento retornará um bool, a partir de um Product, e ele será verificado a cada elemento da lista de Products
                if (criteria.Invoke(p))
                {
                    sum += p.Price;
                }
            }

            return sum;
        }
    }
}
