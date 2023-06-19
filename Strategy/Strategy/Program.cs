using Strategy;

var me = new Myself();
me.ChangeStrategy(new RainWearingStrategy());
me.GoOutside();
