﻿using CommandLine;
using Evolution.Model;

namespace Evolution.Options
{
    [Verb("exec")]
    public class ExecuteOptions : DatabaseAuthenticationOptions, IEvolutionTargetable
    {
        [Option("target", HelpText = "Target Evolution", Required = false)]
        public string TargetEvolution { get; set; }
    }
}