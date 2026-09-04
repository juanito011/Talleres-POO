public class Time
    {
        // ========== CAMPOS PRIVADOS ==========
        private int _hour;
        private int _minute;
        private int _second;
        private int _millisecond;

        // ========== PROPIEDADES ==========
        public int Hour
        {
            get => _hour;
            set
            {
                if (!ValidHour(value))
                    throw new Exception($"The hour: {value}, is not valid.");
                _hour = value;
            }
        }

        public int Minute
        {
            get => _minute;
            set
            {
                if (!ValidMinute(value))
                    throw new Exception($"The minute: {value}, is not valid.");
                _minute = value;
            }
        }

        public int Second
        {
            get => _second;
            set
            {
                if (!ValidSecond(value))
                    throw new Exception($"The second: {value}, is not valid.");
                _second = value;
            }
        }

        public int Millisecond
        {
            get => _millisecond;
            set
            {
                if (!ValidMillisecond(value))
                    throw new Exception($"The millisecond: {value}, is not valid.");
                _millisecond = value;
            }
        }

        // ========== CONSTRUCTORES (5 sobrecargas) ==========
        public Time() : this(0, 0, 0, 0) { }

        public Time(int hour) : this(hour, 0, 0, 0) { }

        public Time(int hour, int minute) : this(hour, minute, 0, 0) { }

        public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }

        public Time(int hour, int minute, int second, int millisecond)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            Millisecond = millisecond;
        }

        // ========== MÉTODOS DE VALIDACIÓN ==========
        public bool ValidHour(int hour) => hour >= 0 && hour <= 23;
        public bool ValidMinute(int minute) => minute >= 0 && minute <= 59;
        public bool ValidSecond(int second) => second >= 0 && second <= 59;
        public bool ValidMillisecond(int millisecond) => millisecond >= 0 && millisecond <= 999;

        // ========== MÉTODOS DE CONVERSIÓN ==========
        public long ToMilliseconds()
        {
            return (long)_hour * 3600000 + (long)_minute * 60000 + (long)_second * 1000 + _millisecond;
        }

        public long ToSeconds()
        {
            return (long)_hour * 3600 + (long)_minute * 60 + _second;
        }

        public long ToMinutes()
        {
            return (long)_hour * 60 + _minute;
        }

        // ========== ToString (formato 12 horas) ==========
        public override string ToString()
        {
            int displayHour = _hour % 12;
            if (displayHour == 0) displayHour = 12;

            string period = _hour < 12 ? "AM" : "PM";

            return $"{displayHour:D2}:{_minute:D2}:{_second:D2}.{_millisecond:D3} {period}";
        }

        // ========== IsOtherDay ==========
        public bool IsOtherDay(Time other)
        {
            long totalMs = this.ToMilliseconds() + other.ToMilliseconds();
            return totalMs >= 24L * 3600000;   // 24 horas en milisegundos
        }

        // ========== Add ==========
        public Time Add(Time other)
        {
            int ms = _millisecond + other._millisecond;
            int sec = _second + other._second;
            int min = _minute + other._minute;
            int hour = _hour + other._hour;

            // Llevar milisegundos
            if (ms > 999)
            {
                sec += ms / 1000;
                ms %= 1000;
            }

            // Llevar segundos
            if (sec > 59)
            {
                min += sec / 60;
                sec %= 60;
            }

            // Llevar minutos
            if (min > 59)
            {
                hour += min / 60;
                min %= 60;
            }

            // Llevar horas (puede pasar de 23 → otro día)
            hour %= 24;

            return new Time(hour, min, sec, ms);
        }
    }
