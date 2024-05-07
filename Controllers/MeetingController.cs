using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Models;

public class MeetingsController : ControllerBase
{
    private readonly MeetingRepository _meetingRepository;

    public MeetingsController(MeetingRepository meetingRepository)
    {
        _meetingRepository = meetingRepository;
    }

    [HttpGet]
    [Route("api/meetings/count")]
    public int GetMeetingCount()
    {
        return _meetingRepository.GetMeetingCount();
    }

    [HttpGet]
    [Route("api/meetings/list")]
    public List<Meeting> GetMeetings()
    {
        return _meetingRepository.GetMeetings();
    }
}
