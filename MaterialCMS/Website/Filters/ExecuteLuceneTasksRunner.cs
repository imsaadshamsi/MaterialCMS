﻿using System.Collections.Generic;
using MaterialCMS.Tasks;

namespace MaterialCMS.Website.Filters
{
    public class ExecuteLuceneTasksRunner : ExecuteEndRequestBase<ExecuteLuceneTasks, int>
    {
        private readonly IQueuedTaskRunner _queuedTaskRunner;

        public ExecuteLuceneTasksRunner(IQueuedTaskRunner queuedTaskRunner)
        {
            _queuedTaskRunner = queuedTaskRunner;
        }

        public override void Execute(IEnumerable<int> data)
        {
            _queuedTaskRunner.ExecuteLuceneTasks();
        }
    }
}