defmodule D3 do
  def main do
    text = IO.gets("Enter a string: ")

    get_len(text)
  end

  def get_len(text) do
    text_len = String.length(text) - 1

    IO.puts(text_len)
  end
end
