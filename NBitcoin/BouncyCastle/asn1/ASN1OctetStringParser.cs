using System.IO;

namespace NBitcoinBTG.BouncyCastle.Asn1
{
	internal interface Asn1OctetStringParser
		: IAsn1Convertible
	{
		Stream GetOctetStream();
	}
}
