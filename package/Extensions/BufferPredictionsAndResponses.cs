using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

[Combinator]
[Description("")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class BufferPredictionsAndResponses
{
    public IObservable<Tuple<double, double>> Process(IObservable<Tuple<double, double>> source)
    {
        return source.Select(value => value);
    }
}
