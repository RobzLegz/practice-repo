defmodule SocketWeb.SocketLive do
  use Phoenix.LiveView
  use SocketWeb, :live_view

  @topic "auction"

  def mount(_params, _session, socket) do
    SocketWeb.Endpoint.subscribe(@topic)
    {:ok, assign(socket, :raised, 0)}
  end

  def render(assigns) do
    ~L"""
      <h1>Raised: <%= @raised %><h1>
      <button phx-click="add5">5</button>
      <button phx-click="add10">10</button>
      <button phx-click="add15">15</button>
    """
  end

  def handle_event("add5", _, socket) do
    raised = socket.assigns.raised + 5
    socket = assign(socket, :raised, raised)
    SocketWeb.Endpoint.broadcast_from(self(), @topic, "donate_event", raised)
    {:noreply, socket}
  end

  def handle_event("add10", _, socket) do
    raised = socket.assigns.raised + 10
    socket = assign(socket, :raised, raised)
    SocketWeb.Endpoint.broadcast_from(self(), @topic, "donate_event", raised)
    {:noreply, socket}
  end

  def handle_event("add15", _, socket) do
    raised = socket.assigns.raised + 15
    socket = assign(socket, :raised, raised)
    SocketWeb.Endpoint.broadcast_from(self(), @topic, "donate_event", raised)
    {:noreply, socket}
  end

  def handle_info(%{topic: @topic, payload: raised}, socket) do
    {:noreply, assign(socket, :raised, raised)}
  end
end
