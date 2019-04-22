using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Dealer
{
    public class DealerResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DealerResponseModel(Domain.Dealer dealer)
        {
            Name = dealer.Name;
            Id = dealer.Id;
        }
    }
}