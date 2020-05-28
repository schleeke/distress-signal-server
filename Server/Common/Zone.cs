using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Common {

    /// <summary>
    /// A zone containing clients.
    /// </summary>
    /// <remarks>
    /// Can have child-zones.
    /// </remarks>
    public class Zone : ICloneable {

        /// <inheritdoc />
        public Zone(string name) {
            Name = name;
            ChildZones = new List<Zone>();
            Identifier = Guid.NewGuid();
        }

        /// <summary>
        /// A list of child zones.
        /// </summary>
        /// <remarks>
        /// Can be empty.
        /// </remarks>
        public IList<Zone> ChildZones { get; }

        /// <summary>
        /// The zone's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The unique identifier for the zone.
        /// </summary>
        public Guid Identifier { get; private set; }

        /// <inheritdoc/>
        public object Clone() {
            var clone = new Zone(Name) {Identifier = Identifier };
            foreach(var z in ChildZones) {
                clone.ChildZones.Add((Zone)z.Clone()); }
            return clone;
        }
    }
}
