defmodule M do
  def main do
    {test_case, _n} = Integer.parse(IO.gets("Choose test case: "))

    case test_case do
      1 -> age_stuff()
      2 -> list_stuff()
      3 -> map_stuff()
    end
  end

  def map_stuff do
    country = String.upcase(IO.gets("Enter a country name: "))
    capitals = %{"LATVIA" => "Riga", "JAPAN" => "Tokyo", "GERMANY" => "Berlin"}

    stop_index = String.length(country) - 2

    find_string = String.slice(country, 0..stop_index)

    test_case = capitals[find_string]

    if test_case do
      IO.puts("Capital city of #{find_string} is #{test_case}")
    else
      IO.puts("Couldn't find find_string in our country list")
    end
  end

  def age_stuff do
    {age, _n} = Integer.parse(IO.gets("Enter Your age: "))

    if age >= 18 do
      IO.puts("You can drive!")
    else
      IO.puts("You can't drive!")
    end
  end

  def list_stuff do
    list1 = [1, 2, 3]
    list2 = [4, 5, 6]
    list3 = [7, 8, 9]

    list4 = list1 ++ list2 ++ list3

    IO.inspect(list4, charlists: :as_lists)

    [_head | tail] = list4

    display_list(tail)

    random_words = ["Very", "random", "words", "in", "a", "list"]

    display_list(random_words)
  end

  def display_list(list) do
    Enum.each list, fn item ->
      IO.puts(item)
    end
  end
end
