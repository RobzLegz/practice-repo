defmodule D5 do
  def get_info do
    date = Date.utc_today()

    year = date.year
    days = Date.days_in_month(date)
    months = Date.months_in_year(date)
    day_of_week = Date.day_of_week(date)

    IO.puts("current year: #{year}")
    IO.puts("days: #{days}")
    IO.puts("months in year: #{months}")
    IO.puts("day of week: #{day_of_week}")
  end

  def year do
    date = ~D[2000-01-01]
    IO.puts(date.year)
  end

  def diff do
    result = Date.diff(~D[2010-04-17], ~D[1970-01-01])
    IO.puts(result)
  end

  def add do
    result = Date.add(~D[1970-01-01], 14716)
    IO.puts(result)
  end

  def get_days_in_month do
    result = Date.days_in_month(~D[1900-09-13])

    IO.puts(result)
  end
end
