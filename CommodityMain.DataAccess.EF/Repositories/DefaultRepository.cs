
using CommodityMain.DataAccess.EF.BaseRepos;
using CommodityMain.DataAccess.EF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.DataAccess.EF
{
    public class CommodityRepository : GenericRepository<commodity>
    {
        public CommodityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class CommodityPriceRepository : GenericRepository<commodityprice>
    {
        public CommodityPriceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class CommodityTypeRepository : GenericRepository<commoditytype>
    {
        public CommodityTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class LocationRepository : GenericRepository<location>
    {
        public LocationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class MeasurementRepository : GenericRepository<measurement>
    {
        public MeasurementRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class RateTypeRepository : GenericRepository<ratetype>
    {
        public RateTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class RateRepository : GenericRepository<rate>
    {
        public RateRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }

    public class ExceptionLogRepository : GenericRepository<exceptionlog>
    {
        public ExceptionLogRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
