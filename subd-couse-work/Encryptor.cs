﻿using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Text;

namespace subd_couse_work
{
    public class Encryptor
    {
        /// <summary>
        /// Contains the relevant Bouncy Castle Methods required to encrypt a password.
        /// References NuGet Package BouncyCastle.Crypto.dll
        /// </summary>

        private static int defaultNumIterations = 1000;
        private static int defaultHashByteSize = 128;
        private static string defaultSalt = Base64Encode("Pesho");
        private static SecureRandom _cryptoRandom;

        public Encryptor()
        {
            _cryptoRandom = new SecureRandom();
        }


        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static int getNumIterations()
        {
            return defaultNumIterations;
        }

        public static string getDefaultSalt()
        {
            return defaultSalt;
        }

        public static int getHashByteSize()
        {
            return defaultHashByteSize;
        }
        /// <summary>
        /// Random Salt Creation
        /// </summary>
        /// <param name="size">The size of the salt in bytes</param>
        /// <returns>A random salt of the required size.</returns>
        public static byte[] CreateSalt(int size)
        {
            byte[] salt = new byte[size];
            _cryptoRandom.NextBytes(salt);
            return salt;
        }

        /// <summary>
        /// Gets a PBKDF2_SHA256 Hash  (Overload)
        /// </summary>
        /// <param name="password">The password as a plain text string</param>
        /// <param name="saltAsBase64String">The salt for the password</param>
        /// <param name="iterations">The number of times to encrypt the password</param>
        /// <param name="hashByteSize">The byte size of the final hash</param>
        /// <returns>A base64 string of the hash.</returns>
        /// 
        public static string computeHash(string password)
        {
            return computeHash(password, defaultSalt, defaultNumIterations, defaultHashByteSize);
        }

        public static string computeHash(string password, string saltAsBase64String, int iterations, int hashByteSize)
        {
            var saltBytes = Convert.FromBase64String(saltAsBase64String);
            var hash = computeHash(password, saltBytes, iterations, hashByteSize);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Gets a PBKDF2_SHA256 Hash (CORE METHOD)
        /// </summary>
        /// <param name="password">The password as a plain text string</param>
        /// <param name="salt">The salt as a byte array</param>
        /// <param name="iterations">The number of times to encrypt the password</param>
        /// <param name="hashByteSize">The byte size of the final hash</param>
        /// <returns>A the hash as a byte array.</returns>
        public static byte[] computeHash(string password, byte[] salt, int iterations, int hashByteSize)
        {
            var pdb = new Pkcs5S2ParametersGenerator(new Org.BouncyCastle.Crypto.Digests.Sha256Digest());
            pdb.Init(PbeParametersGenerator.Pkcs5PasswordToBytes(password.ToCharArray()), salt,
                            iterations);
            var key = (KeyParameter)pdb.GenerateDerivedMacParameters(hashByteSize * 8);
            return key.GetKey();
        }

        /// <summary>
        /// Validates a password given a hash of the correct one. (OVERLOAD)
        /// </summary>
        /// <param name="password">The original password to hash</param>
        /// <param name="salt">The salt that was used when hashing the password</param>
        /// <param name="iterations">The number of times it was encrypted</param>
        /// <param name="hashByteSize">The byte size of the final hash</param>
        /// <param name="hashAsBase64String">The hash the password previously provided as a base64 string</param>
        /// <returns>True if the hashes match</returns>

        public static bool ValidatePassword(string password, string hashAsBase64String)
        {
            return ValidatePassword(password, defaultSalt, defaultNumIterations, defaultHashByteSize, hashAsBase64String);
        }

        public static bool ValidatePassword(string password, string salt, int iterations, int hashByteSize, string hashAsBase64String)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] actualHashBytes = Convert.FromBase64String(hashAsBase64String);
            return ValidatePassword(password, saltBytes, iterations, hashByteSize, actualHashBytes);
        }

        /// <summary>
        /// Validates a password given a hash of the correct one (MAIN METHOD).
        /// </summary>
        /// <param name="password">The password to check.</param>
        /// <param name="correctHash">A hash of the correct password.</param>
        /// <returns>True if the password is correct. False otherwise.</returns>
        public static bool ValidatePassword(string password, byte[] saltBytes, int iterations, int hashByteSize, byte[] actualGainedHasAsByteArray)
        {
            byte[] testHash = computeHash(password, saltBytes, iterations, hashByteSize);
            return SlowEquals(actualGainedHasAsByteArray, testHash);
        }

        /// <summary>
        /// Compares two byte arrays in length-constant time. This comparison
        /// method is used so that password hashes cannot be extracted from
        /// on-line systems using a timing attack and then attacked off-line.
        /// </summary>
        /// <param name="a">The first byte array.</param>
        /// <param name="b">The second byte array.</param>
        /// <returns>True if both byte arrays are equal. False otherwise.</returns>
        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        
    }

}
