﻿namespace NBitcoinBTG.BouncyCastle.Math.Field
{
	internal interface IPolynomialExtensionField
		: IExtensionField
	{
		IPolynomial MinimalPolynomial
		{
			get;
		}
	}
}
