﻿using BirdAPI.ApiService.Database.Models;
using Neo4j.Berries.OGM.Contexts;
using Neo4j.Berries.OGM.Models.Sets;

namespace BirdAPI.ApiService.Database;

public class ApplicationGraphContext(Neo4jOptions options) : GraphContext(options)
{
    public NodeSet<Recording> Recordings { get; private set; }
    public NodeSet<User> Users { get; private set; }
    public NodeSet<XenoCantoEntry> XenoCantoEntries { get; private set; }
} 