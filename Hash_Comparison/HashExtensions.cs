using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hash_Comparison
{
    public static class HashExtensions
    {
        public static string ComputeSha224Hash(BackgroundWorker bw, Stream fileStream)
        {
            var buffer = new byte[65536];
            int bytesRead;

            long updateScore = 0;
            long totalSize = fileStream.Length;
            Sha224Digest sha224 = new Sha224Digest();

            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                if (bw.CancellationPending) break;
                sha224.BlockUpdate(buffer, 0, bytesRead);

                Thread.Sleep(1);
                bw.ReportProgress((int)updateScore, bytesRead);
                updateScore += bytesRead;
            }

            byte[] res = new byte[sha224.GetDigestSize()];
            sha224.DoFinal(res, 0);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < res.Length; i++)
                sb.Append(res[i].ToString("X2"));

            return sb.ToString();
        }

        public static string ComputeHash(this System.Security.Cryptography.HashAlgorithm hashAlgorithm, BackgroundWorker bw, Stream fileStream)
        {
            var buffer = new byte[65536];
            int bytesRead;

            long updateScore = 0;
            long totalSize = fileStream.Length;

            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                if (bw.CancellationPending) break;
                hashAlgorithm.TransformBlock(buffer, 0, bytesRead, null, 0);

                Thread.Sleep(1);
                bw.ReportProgress((int)updateScore, bytesRead);
                updateScore += bytesRead;
            }

            hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
            byte[] res = hashAlgorithm.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < res.Length; i++)
                sb.Append(res[i].ToString("X2"));

            return sb.ToString();
        }
    }
}
