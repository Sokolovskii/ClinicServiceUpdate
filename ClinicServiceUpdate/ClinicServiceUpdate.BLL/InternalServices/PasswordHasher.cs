using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace ClinicServiceUpdate.BLL.InternalServices
{
	public static class PasswordHasher
	{
		public static string GetPassHash(this string password)
		{
			byte[] salt = new byte[128 / 8];
			using(var rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetNonZeroBytes(salt);
			}
			return Convert.ToBase64String(KeyDerivation.Pbkdf2(
				password: password,
				salt: salt,
				prf: KeyDerivationPrf.HMACSHA256,
				iterationCount: 10,
				numBytesRequested: 256 / 8));
		}
	}
}
