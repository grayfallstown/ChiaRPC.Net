using System;

namespace ChiaRPC.Routes
{
    internal static class FullNodeRoutes
    {
        public static Uri GetBlockchainState()
            => new Uri("get_blockchain_state", UriKind.Relative);

        public static Uri GetBlock()
            => new Uri("get_block", UriKind.Relative);

        public static Uri GetBlocks()
            => new Uri("get_blocks", UriKind.Relative);

        public static Uri GetRecentSignagePointOrEos()
            => new Uri("get_recent_signage_point_or_eos", UriKind.Relative);

        public static Uri GetCoinRecordByName()
            => new Uri("get_coin_record_by_name", UriKind.Relative);

        public static Uri GetPuzzleAndSolution()
            => new Uri("get_puzzle_and_solution", UriKind.Relative);
    }
}
