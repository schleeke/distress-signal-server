using System;
using System.Collections.Generic;
using System.Text;

namespace Common {

    /// <summary>
    /// A client within the Distress Signal Service infrastructure.
    /// Generally available of triggering and acknowledging distress signals.
    /// </summary>
    public class Client : ICloneable {

        /// <inheritdoc/>
        public Client(string name) {
            Name = name;
            Identifier = Guid.NewGuid();
        }

        /// <summary>
        /// The unique identifier for the client.
        /// </summary>
        public Guid Identifier { get; private set; }


        /// <summary>
        /// The client's name.
        /// Must be unique within its zone.
        /// </summary>
        public string Name { get; }

        /// <inheritdoc/>
        public object Clone() {
            var clone = new Client(Name) { Identifier = Identifier };
            return clone;
        }
    }
}
