using BenchmarkDotNet.Attributes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace benchmark.dapper.async
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class DapperAsyncMethodBenchMark
    {
        [Benchmark]
        public async Task GetAsync()
        {
            using (var conexao = new NpgsqlConnection("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=sgp_db;Pooling=true"))
            {
                await conexao.QueryFirstOrDefaultAsync("select * from evento"); 
            }
            
        }
        [Benchmark]
        public  void Get()
        {
            using (var conexao = new NpgsqlConnection("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=sgp_db;Pooling=true"))
            {
                 conexao.QueryFirstOrDefault("select * from evento");
            }

        }
    }
}
