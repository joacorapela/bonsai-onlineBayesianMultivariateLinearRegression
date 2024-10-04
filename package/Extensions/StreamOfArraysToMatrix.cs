using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

[Combinator]
[Description("")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class StreamOfArraysToMatrix
{
    public IObservable<double[]> Process(IObservable<double[]> source)
    {
        
        return source.Select(value => value);
    }
}
