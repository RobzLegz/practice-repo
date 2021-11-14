import Config

# We don't run a server during test. If one is required,
# you can enable the server option below.
config :couter, CouterWeb.Endpoint,
  http: [ip: {127, 0, 0, 1}, port: 4002],
  secret_key_base: "cttSHJbqzJe3DksbQAzr+IsuH+i0OQeeBGcpSxnl7f6/3q0BhFGuqBttJt7djnFr",
  server: false

# In test we don't send emails.
config :couter, Couter.Mailer,
  adapter: Swoosh.Adapters.Test

# Print only warnings and errors during test
config :logger, level: :warn

# Initialize plugs at runtime for faster test compilation
config :phoenix, :plug_init_mode, :runtime
