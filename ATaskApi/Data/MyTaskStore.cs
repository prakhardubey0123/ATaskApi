﻿using ATaskApi.Models.DTO;

namespace ATaskApi.Data
{
    public class MyTaskStore
    {
        public static List<MyTaskDTO> TaskList = new List<MyTaskDTO>
        {
            new MyTaskDTO
            {
                Id = 1,
                TaskName= "DemoTask1",
                TaskDescription="This is Demo Task 1"
            },
            new MyTaskDTO
            {
                Id=2,
                TaskName="DemoTask2",
                TaskDescription="This is Demotask2"
            },
            new MyTaskDTO
            {
                Id=3,
                TaskName="DemoTask3",
                TaskDescription="This is Demotask3"
            },
            new MyTaskDTO
            {
                Id=4,
                TaskName="DemoTask4",
                TaskDescription="This is Demotask4"
            }


        };
    }
}
