using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain;
using System.Linq;

namespace CleanArchitecture.Application.Dealer
{
    public class GetDealerDetails : IGetDealerDetails
    {
        private readonly IRepository<Domain.Dealer> _dealerRepository;

        public GetDealerDetails(IRepository<Domain.Dealer> dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public IList<DealerResponseModel> Execute()
        {
            return _dealerRepository.GetAll().ToList().Select<Domain.Dealer, DealerResponseModel>((x) =>
            {
                return new DealerResponseModel(x);
            }).ToList();
        }

        public DealerResponseModel Execute(int id)
        {
            var dealer = _dealerRepository.GetById(id);
            return new DealerResponseModel(dealer);
        }
    }
}