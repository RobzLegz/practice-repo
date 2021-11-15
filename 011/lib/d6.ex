defmodule D6 do
  def main do
    IO.puts("Ziemeli: 1")
    IO.puts("Dienvidi: 2")
    IO.puts("Rietumi: 3")
    IO.puts("Austrumi: 4")

    IO.puts("")

    {direction, _n} = Integer.parse(IO.gets("Enter direction number: "))

    IO.puts("")

    IO.puts("Pa kreisi: -1")
    IO.puts("Taisni: 0")
    IO.puts("Pa labi: 1")

    action = IO.gets("Enter action: ")

    case direction do
      1 -> ziemeli(action)
      2 -> dienvidi(action)
      3 -> rietumi(action)
      4 -> austrumi(action)
      _ -> IO.puts("Incorrect test case")
    end
  end

  def ziemeli(action) do
    checkAction(action)

  end

  def dienvidi(action) do
    checkAction(action)

  end

  def rietumi(action) do
    checkAction(action)

  end

  def austrumi(action) do
    checkAction(action)

  end

  def checkAction(action) do
    if action != "-1" and action != "0" and action != "1" do
      IO.puts("Incorrect value")
    end
  end
end
