using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Trace
    {
        public int RowNumber { get; set; }
        public decimal? EventClass { get; set; }
        public string? TextData { get; set; }
        public string? NtuserName { get; set; }
        public decimal? ClientProcessId { get; set; }
        public string? ApplicationName { get; set; }
        public string? SqluserName { get; set; }
        public decimal? Spid { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? Reads { get; set; }
        public decimal? Writes { get; set; }
        public decimal? Cpu { get; set; }
    }
}
