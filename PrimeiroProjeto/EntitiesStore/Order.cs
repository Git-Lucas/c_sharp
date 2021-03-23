using PrimeiroProjeto.EntitiesStore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesStore
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Adiciona o objeto OrderItem à lista OrderItems
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        //Remove o objeto OrderItem da lista OrderItems
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        //Calcula o valor total do pedido
        public double Total()
        {
            double total = 0;

            foreach (OrderItem oi in OrderItems)
            {
                total += oi.Price;
            }

            return total;
        }

        //Imprime as informações do pedido, segundo padrão do exercício
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem oi in OrderItems)
            {
                sb.Append(oi.Product.Name);
                sb.Append(", R$");
                sb.Append(oi.Product.Price.ToString("F2"));
                sb.Append(", Quantity: ");
                sb.Append(oi.Quantity);
                sb.Append(", Subtotal: R$");
                sb.AppendLine(oi.SubTotal().ToString("F2"));
            }
            sb.Append("Total price: R$");
            sb.Append(Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
