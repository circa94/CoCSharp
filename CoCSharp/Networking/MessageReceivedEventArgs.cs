﻿using System;

namespace CoCSharp.Networking
{
    /// <summary>
    /// Provides data for message received event.
    /// </summary>
    public class MessageReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageReceivedEventArgs"/> class.
        /// </summary>
        public MessageReceivedEventArgs()
        {
            // Space
        }

        /// <summary>
        /// Gets or sets the <see cref="Networking.Message"/> that has been
        /// received.
        /// </summary>
        public Message Message { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="System.Exception"/> that occured during
        /// the reading of the <see cref="Networking.Message"/>. Returns null if no
        /// error occured during reading.
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Networking.Message"/> raw bytes that was received from
        /// the network. This includes the header and the body encrypted.
        /// </summary>
        public byte[] MessageData { get; set; }
    }
}
