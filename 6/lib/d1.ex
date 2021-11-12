defmodule D1 do
  def sum_two do
    {x, _n} = Integer.parse(IO.gets("Please input number X: "))
    {y, _n} = Integer.parse(IO.gets("Please input number Y: "))

    result = x + y
    IO.puts("SUM:")
    IO.puts(result)
  end
end
