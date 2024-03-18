namespace Microsoft.Graph
{
    using System.Collections.Generic;

    internal class KeyedBatchResponseContentCustom
    {
        internal readonly HashSet<string> Keys;
        internal readonly BatchResponseContent Response;

        public KeyedBatchResponseContentCustom(HashSet<string> keys, BatchResponseContent response)
        {
            Keys = keys;
            Response = response;
        }
    }
}