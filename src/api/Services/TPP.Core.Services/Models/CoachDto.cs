﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace TPP.Core.Services.Models
{
    public class CoachDto : UserDto
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public string CoachPhoto { get; set; }

    }
}