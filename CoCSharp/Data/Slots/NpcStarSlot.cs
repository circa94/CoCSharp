﻿using CoCSharp.Networking;

namespace CoCSharp.Data.Slots
{
    /// <summary>
    /// Represents a Clash of Clans npc star slot.
    /// </summary>
    public class NpcStarSlot : Slot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpcStarSlot"/> class.
        /// </summary>
        public NpcStarSlot()
        {
            // Space
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NpcStarSlot"/> class with
        /// the specified NPC ID and star amount.
        /// </summary>
        /// <param name="id">ID of the NPC.</param>
        /// <param name="star">Star amount.</param>
        public NpcStarSlot(int id, int star)
        {
            ID = id;
            Star = star;   
        }

        /// <summary>
        /// Gets or sets the NPC ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the star amount.
        /// </summary>
        public int Star { get; set; }

        /// <summary>
        /// Reads the <see cref="NpcStarSlot"/> from the specified <see cref="MessageReader"/>.
        /// </summary>
        /// <param name="reader">
        /// <see cref="MessageReader"/> that will be used to read the <see cref="NpcStarSlot"/>.
        /// </param>
        public override void ReadSlot(MessageReader reader)
        {
            ID = reader.ReadInt32();
            Star = reader.ReadInt32();
        }

        /// <summary>
        /// Writes the <see cref="NpcStarSlot"/> to the specified <see cref="MessageWriter"/>.
        /// </summary>
        /// <param name="writer">
        /// <see cref="MessageWriter"/> that will be used to write the <see cref="NpcStarSlot"/>.
        /// </param>
        public override void WriteSlot(MessageWriter writer)
        {
            writer.Write(ID);
            writer.Write(Star);
        }
    }
}
