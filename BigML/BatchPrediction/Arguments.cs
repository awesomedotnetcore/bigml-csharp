using System.Collections.Generic;
using System.Json;
using System.Linq;

namespace BigML
{
    public partial class BatchPrediction
    {
        public class Arguments : Arguments<BatchPrediction>
        {
            public Arguments()
            {

            }

            /// <summary>
            /// A valid dataset/id.
            /// </summary>
            public string DataSet
            {
                get;
                set;
            }

            /// <summary>
            /// A valid model/id.
            /// </summary>
            public string Model
            {
                get;
                set;
            }

            /// <summary>
            /// A valid ensemble/id.
            /// </summary>
            public string Ensemble
            {
                get;
                set;
            }

            /// <summary>
            /// A valid logisticregression/id.
            /// </summary>
            public string LogisticRegression
            {
                get;
                set;
            }

            public override JsonValue ToJson()
            {
                dynamic json = base.ToJson();

                if (!string.IsNullOrWhiteSpace(DataSet)) json.dataset = DataSet;
                if (!string.IsNullOrWhiteSpace(DataSet)) json.model = Model;
                if (!string.IsNullOrWhiteSpace(DataSet)) json.ensemble = Ensemble;
                return json;
            }
        }
    }
}