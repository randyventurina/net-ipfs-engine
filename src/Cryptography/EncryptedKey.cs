﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ipfs.Engine.Cryptography
{
    /// <summary>
    ///   A private key that is password protected.
    /// </summary>
    class EncryptedKey
    {
        /// <summary>
        ///   The local name of the key.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        public string Name { get; set; }

        /// <summary>
        ///   PKCS #8 container.
        /// </summary>
        /// <value>
        ///   Password protected PKCS #8 structure in the PEM format
        /// </value>
        [Column(Order = 1)]
        public string Pem { get; set; }

    }
}
