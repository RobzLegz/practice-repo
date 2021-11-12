defmodule D4 do
  def todo do
    #The pipe operator |> passes the result of an expression as the first parameter of another expression.
    {number_of_tasks, _} = IO.gets("Enter number of tasks you want to add: ") |> Integer.parse()
    IO.puts(number_of_tasks)
  end

  def temp_todos do
    ["eat", "homework", "build"]
  end

  def contains?(tasks, task) do
    Enum.member?(tasks, task)
  end
end
