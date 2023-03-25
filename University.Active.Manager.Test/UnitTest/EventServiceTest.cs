using AutoFixture;
using Moq;
using FluentAssertions;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;
using University.Active.Manager.Services;

namespace University.Active.Manager.Test.UnitTest;

public class EventServiceTest
{
    private readonly Mock<IEventRepository> _eventRepositoryMock;
    private Fixture _fixture;

    public EventServiceTest()
    {
        _eventRepositoryMock = new Mock<IEventRepository>();
        _fixture = new Fixture();
    }
    
    [Fact]
    public async Task Get_All_Events_Should_Be_Return_List_Actual_Events()
    {
        //stub
        var events = _fixture.Build<Event>()
            .Without(x=> x.Students).CreateMany(5).ToList();
        
        //Делаем 1 завершеным чтобы проверить что 1 запись точно не вернется в результате
        events[0].IsDone = true;
        //moq
        _eventRepositoryMock.Setup(repository => repository.GetAllEvents()).ReturnsAsync(events);

        var eventService = new EventService(_eventRepositoryMock.Object);
        var result = await eventService.GetAllActiveEvents();

        result.Should().NotContain(events[0]);
    }
}