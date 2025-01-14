﻿using Newtonsoft.Json.Linq;

namespace Elsa.Models
{
    public class WorkflowExecutionScope
    {
        public WorkflowExecutionScope()
        {
            Variables = new Variables();
        }

        public JToken LastResult { get; set; }
        public Variables Variables { get; }

        public void SetVariable(string variableName, object value)
        {
            Variables[variableName] = JToken.FromObject(value);
        }

        public T GetVariable<T>(string name) => Variables.GetVariable<T>(name);
        public JToken GetVariable(string name) => Variables.GetVariable(name);
    }
}