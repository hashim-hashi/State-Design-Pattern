StopWatch.IContextBase stopwatch = new StopWatch.Context(new StopWatch.ConcreteState.InitialScreenState());

//press 2nd button => nothing happens
stopwatch.PressSecondButton();//nothing happen

//start, lap, lap, stop, restart, lap, stop, reset
stopwatch.PressFirstButton();//started
stopwatch.PressSecondButton();//lap
stopwatch.PressSecondButton();//lap
stopwatch.PressFirstButton();//stop
stopwatch.PressFirstButton();//restart
stopwatch.PressSecondButton();//lap
stopwatch.PressFirstButton();//stop
stopwatch.PressSecondButton();//reset
