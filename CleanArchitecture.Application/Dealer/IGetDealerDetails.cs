using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Dealer
{
    public interface IGetDealerDetails
    {
        IList<DealerResponseModel> Execute();

        DealerResponseModel Execute(int id);
    }
}