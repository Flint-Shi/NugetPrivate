using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CommonLibrary.OrderManagement
{
    public enum TestOrderStatus
    {
        Requested = 0,
        Loaded = 1,
        InProcess = 2,
        Measured = 3,
        Completed = 4,
        Error = 5
    }

    public class TestOrder
    {
     
        public int TestOrderDBId { get; set; }

     
        public string AssayName { get; set; }

     
        public string AssayType { get; set; }

     
        public string AssayVersionString { get; set; }

     
        public string SampleID { get; set; }



     
        public DateTime CreationTime { get; set; }

     
        public TestOrderStatus Status { get; set; }

     
        public DateTime MeasurementTime { get; set; }

     
        public int ResultStatus { get; set; }

     
        public List<uint> InstrumentFlags { get; set; }

     
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Thermal cycler bank id, 0 to 11 (left to right)
        /// </summary>
     
        public int TCBankId { get; set; }

        /// <summary>
        /// Pcr Reaction tube id, 0 to 3 (front to back)
        /// </summary>
     
        public int PcrReactionTubeId { get; set; }

     
        public string ExternalQualityControlFlag { get; set; }
        
     


     
        public string Operator { get; set; }

        #region Constructors

        public TestOrder()
        {
            TCBankId = -1;
            PcrReactionTubeId = -1;
            CreationTime = DateTime.UtcNow;
            MeasurementTime = new DateTime();
            Status = TestOrderStatus.Requested;
            InstrumentFlags = new List<uint>();
        }

        #endregion
    }
}
