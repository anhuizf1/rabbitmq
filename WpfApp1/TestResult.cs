using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp1
{
 

    public class TestInfo
    {
        public string OjbectID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int TestSteps { get; set; }

        public int Scale { get; set; }
        public List<RSFact_TestDataCollecting> Rows { get; set; }
    }

    public class RSFact_TestDataCollecting
    {
        [XmlAttribute]
        public long FactID { get; set; }
        [XmlAttribute]
        public long PartitionPolicy { get; set; }
        [XmlAttribute]
        public string WFInstanceID { get; set; }
        [XmlAttribute]
        public int Ordinal { get; set; }
        [XmlAttribute]
        public int T128LeafID { get; set; }
        [XmlAttribute]
        public string MetricName { get; set; }
        [XmlAttribute]
        public float LowLimit { get; set; }
        [XmlAttribute]
        public string Criterion { get; set; }
        [XmlAttribute]
        public float HighLimit { get; set; }
        [XmlAttribute]
        public int Scale { get; set; }
        [XmlAttribute]
        public string UnitOfMeasure { get; set; }
        [XmlAttribute]
        public string Conclusion { get; set; }
        [XmlAttribute]
        public string Remark { get; set; }
        [XmlAttribute]
        public float Metric01 { get; set; }
        [XmlAttribute]
        public float Metric02 { get; set; }
        [XmlAttribute]
        public float Metric03 { get; set; }
        [XmlAttribute]
        public float Metric04 { get; set; }
        [XmlAttribute]
        public float Metric05 { get; set; }
        [XmlAttribute]
        public float Metric06 { get; set; }
        [XmlAttribute]
        public float Metric07 { get; set; }
        [XmlAttribute]
        public float Metric08 { get; set; }
        [XmlAttribute]
        public float Metric09 { get; set; }
        [XmlAttribute]
        public float Metric10 { get; set; }
        [XmlAttribute]
        public float Metric11 { get; set; }
        [XmlAttribute]
        public float Metric12 { get; set; }
        [XmlAttribute]
        public float Metric13 { get; set; }
        [XmlAttribute]
        public float Metric14 { get; set; }
        [XmlAttribute]
        public float Metric15 { get; set; }
        [XmlAttribute]
        public float Metric16 { get; set; }
        [XmlAttribute]
        public float Metric17 { get; set; }
        [XmlAttribute]
        public float Metric18 { get; set; }
        [XmlAttribute]
        public float Metric19 { get; set; }
        [XmlAttribute]
        public float Metric20 { get; set; }
        [XmlAttribute]
        public float Metric21 { get; set; }
        [XmlAttribute]
        public float Metric22 { get; set; }
        [XmlAttribute]
        public float Metric23 { get; set; }
        [XmlAttribute]
        public float Metric24 { get; set; }
        [XmlAttribute]
        public float Metric25 { get; set; }
        [XmlAttribute]
        public float Metric26 { get; set; }
        [XmlAttribute]
        public float Metric27 { get; set; }
        [XmlAttribute]
        public float Metric28 { get; set; }
        [XmlAttribute]
        public float Metric29 { get; set; }
        [XmlAttribute]
        public float Metric30 { get; set; }
        [XmlAttribute]
        public float Metric31 { get; set; }
        [XmlAttribute]
        public float Metric32 { get; set; }

    }
}
