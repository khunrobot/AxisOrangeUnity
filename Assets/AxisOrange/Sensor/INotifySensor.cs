﻿using System;

namespace AxisOrange {
    public interface INotifySensor : ISensor {
        void Listen();
        void Unlisten();
        event Action<AxisOrangeDataData> OnSensorDataUpdate;
        event Action<AxisOrangeButton> OnSensorButtonUpdate;
    }
}
