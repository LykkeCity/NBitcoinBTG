using System.Threading.Tasks;

namespace NBitcoinBTG
{
	public interface IBlockRepository
	{
		Task<Block> GetBlockAsync(uint256 blockId);
	}
}
