defmodule HelloWeb.SushouseChannel do
  use HelloWeb, :channel

  @impl true
  def join("sushouse:lobby", _payload, socket) do
    {:ok, socket}
  end

  @impl true
  def handle_in("shout", payload, socket) do
    broadcast socket, "shout", payload
    {:noreply, socket}
  end
end
