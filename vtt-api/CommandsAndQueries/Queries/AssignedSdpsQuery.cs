﻿using Vtt_Api.CommandAndQueryProtocol;
using Vtt_Api.Domain.Dtos;

namespace Vtt_Api.CommandsAndQueries.Queries
{
    public class AssignedSdpsQuery : VttRequest<List<RegionForUi>>
    {
    }
}
