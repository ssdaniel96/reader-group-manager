using Domain.Entities.Base;
using Domain.ValueObject;

namespace Domain.Entities;

public class Reminder : Entity
{
    public Member KickOff { get; private set; }
    public int KickOffId { get; private set; }
    public Member Responsible { get; private set; }
    public int ResponsibleId { get; private set; }
    public Member Prayer { get; private set; }
    public int PrayerId { get; private set; }
    
    public ReminderNote ReminderNote { get; private set; }  
    
    // navigators
    
    public int ReadingPlanId { get; private set; }
    public ReadingPlan ReadingPlan { get; private set; }
    
    protected Reminder(){ }

    public Reminder(
        ReadingPlan readingPlan,
        Member kickOff, 
        Member responsible, 
        Member prayer, 
        int page, 
        string chapter, 
        int paragraph)
    {
        ReadingPlanId = readingPlan.Id;
        ReadingPlan = readingPlan;
        KickOff = kickOff;
        KickOffId = kickOff.Id;
        Responsible = responsible;
        ResponsibleId = responsible.Id;
        Prayer = prayer;
        PrayerId = prayer.Id;
        ReminderNote = new(page, chapter, paragraph);
    }
}