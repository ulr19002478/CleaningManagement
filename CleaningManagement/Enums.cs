using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningManagement
{
    public class Enums
    {
        public enum CommercialType
        {
            OFFICE,
            WAREHOUSE,
            FACTORY,
            INDUSTRIAL_UNIT,
            RETAIL
        }
        public enum DomesticType
        {
            DETACHED,
            SEMI_DETACHED,
            TERRACED,
            BUNGALOW,
            COTTAGE,
            FLAT
        }
        public enum Severity
        {
            HIGH,
            MEDIUM,
            LOW
        }
    }
}
