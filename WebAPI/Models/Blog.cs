﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Blog
{
    public int BlogId { get; set; }

    public string? BlogTitle { get; set; }

    public string? BlogAuthor { get; set; }

    public string? BlogContent { get; set; }
}
