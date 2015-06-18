using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using USC.GISResearchLab.Geocoding.Core.Metadata.ReferenceSources;
using USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures;

namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatureSets
{
    public class ReferenceFeatureSet
    {
        #region Properties

        public List<IReferenceFeature> ReferenceFeatures { get; set; }
        public ReferenceSourceType ReferenceSourceType { get; set; }

        public string Error { get; set; }
        public bool ExceptionOccurred { get; set; }

        [XmlIgnore]
        public Exception Exception { get; set; }

        public DateTime TimeStartGetFeaturesFromDataRow { get; set; }
        public DateTime TimeEndGetFeaturesFromDataRow { get; set; }
        public TimeSpan DurationGetFeaturesFromDataRow
        {
            get
            {
                TimeSpan ret = new TimeSpan(99, 00, 00);
                if (TimeStartGetFeaturesFromDataRow != null && TimeEndGetFeaturesFromDataRow != null)
                {
                    ret = new TimeSpan(TimeEndGetFeaturesFromDataRow.Ticks - TimeStartGetFeaturesFromDataRow.Ticks);
                }
                return ret;
            }
        }

        public DateTime TimeStartCalculatingMinBlocksAway { get; set; }
        public DateTime TimeEndCalculatingMinBlocksAway { get; set; }
        public TimeSpan DurationCalculatingMinBlocksAway
        {
            get
            {
                TimeSpan ret = new TimeSpan(99, 00, 00);
                if (TimeStartCalculatingMinBlocksAway != null && TimeEndCalculatingMinBlocksAway != null)
                {
                    ret = new TimeSpan(TimeEndCalculatingMinBlocksAway.Ticks - TimeStartCalculatingMinBlocksAway.Ticks);
                }
                return ret;
            }
        }

        public DateTime TimeStartNumericChecking { get; set; }
        public DateTime TimeEndNumericChecking { get; set; }
        public TimeSpan DurationNumericChecking
        {
            get
            {
                TimeSpan ret = new TimeSpan(99, 00, 00);
                if (TimeStartNumericChecking != null && TimeEndNumericChecking != null)
                {
                    ret = new TimeSpan(TimeEndNumericChecking.Ticks - TimeStartNumericChecking.Ticks);
                }
                return ret;
            }
        }

        public DateTime TimeStartGetFeatureFromDataRow { get; set; }
        public DateTime TimeEndGetFeatureFromDataRow { get; set; }
        public TimeSpan DurationGetFeatureFromDataRow
        {
            get
            {
                TimeSpan ret = new TimeSpan(99, 00, 00);
                if (TimeStartGetFeatureFromDataRow != null && TimeEndGetFeatureFromDataRow != null)
                {
                    ret = new TimeSpan(TimeEndGetFeatureFromDataRow.Ticks - TimeStartGetFeatureFromDataRow.Ticks);
                }
                return ret;
            }
        }

        public DateTime TimeStartAliasAddressParsing { get; set; }
        public DateTime TimeEndAliasAddressParsing { get; set; }
        public TimeSpan DurationAliasAddressParsing
        {
            get
            {
                TimeSpan ret = new TimeSpan(99, 00, 00);
                if (TimeStartAliasAddressParsing != null && TimeEndAliasAddressParsing != null)
                {
                    ret = new TimeSpan(TimeEndAliasAddressParsing.Ticks - TimeStartAliasAddressParsing.Ticks);
                }
                return ret;
            }
        }

        #endregion

        public ReferenceFeatureSet()
        {
            ReferenceFeatures = new List<IReferenceFeature>();
        }

        public void Add(IReferenceFeature feature)
        {
            ReferenceFeatures.Add(feature);
        }
    }
}