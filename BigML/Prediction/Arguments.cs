using System.Collections.Generic;
using System.Json;

namespace BigML
{
    public partial class Prediction
    {
        public class Arguments : Arguments<Prediction>
        {
            public Arguments()
            {
                InputData = new Dictionary<string, object>();
            }

            /// <summary>
            /// An object with field's id/value pairs representing the instance you want to create a prediction for.  
            /// </summary>
            public IDictionary<string,object> InputData
            {
                get;
                private set;
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

                if (Ensemble != null)
                {
                    json.ensemble = Ensemble;
                }
                if (LogisticRegression != null)
                {
                    json.logisticregression = LogisticRegression;
                }
                if (Model != null)
                {
                    json.model = Model;
                }

                if (InputData.Count > 0)
                {
                    var input_data = new JsonObject();
                    foreach(var kv in InputData)
                    {
                        JsonPrimitive value;
                        JsonPrimitive.TryCreate(kv.Value, out value);
                        input_data[kv.Key] = value;
                    }
                    json.input_data = input_data;
                }
                   
                return json;
            }
        }
    }
}