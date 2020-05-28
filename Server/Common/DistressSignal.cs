using System;
using System.Collections.Generic;
using System.Text;

namespace Common {
    /// <summary>
    /// A distress signal triggered by a <see cref="Client"/>.
    /// </summary>
    public class DistressSignal {

        /// <inheritdoc/>
        public DistressSignal(ulong id) {
            Id = id;
        }

        /// <summary>
        /// The id of the distress signal.
        /// </summary>
        public ulong Id { get; }

    }
}
