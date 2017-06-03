defmodule Hydrosol.Soumission do
  @moduledoc """
  The boundary for the Soumission system.
  """

  import Ecto.Query, warn: false
  alias Hydrosol.Repo

  alias Hydrosol.Soumission.Residentiel
  alias Hydrosol.Soumission.Commercial

  @doc """
  Returns the list of residentiels.

  ## Examples

      iex> list_residentiels()
      [%Residentiel{}, ...]

  """
  def list_residentiels do
    Repo.all(Residentiel)
  end

  @doc """
  Gets a single residentiel.

  Raises `Ecto.NoResultsError` if the Residentiel does not exist.

  ## Examples

      iex> get_residentiel!(123)
      %Residentiel{}

      iex> get_residentiel!(456)
      ** (Ecto.NoResultsError)

  """
  def get_residentiel!(id), do: Repo.get!(Residentiel, id)

  @doc """
  Creates a residentiel.

  ## Examples

      iex> create_residentiel(%{field: value})
      {:ok, %Residentiel{}}

      iex> create_residentiel(%{field: bad_value})
      {:error, %Ecto.Changeset{}}

  """
  def create_residentiel(attrs \\ %{}) do
    %Residentiel{}
    |> Residentiel.changeset(attrs)
    |> Repo.insert()
  end

  @doc """
  Updates a residentiel.

  ## Examples

      iex> update_residentiel(residentiel, %{field: new_value})
      {:ok, %Residentiel{}}

      iex> update_residentiel(residentiel, %{field: bad_value})
      {:error, %Ecto.Changeset{}}

  """
  def update_residentiel(%Residentiel{} = residentiel, attrs) do
    residentiel
    |> Residentiel.changeset(attrs)
    |> Repo.update()
  end

  @doc """
  Deletes a Residentiel.

  ## Examples

      iex> delete_residentiel(residentiel)
      {:ok, %Residentiel{}}

      iex> delete_residentiel(residentiel)
      {:error, %Ecto.Changeset{}}

  """
  def delete_residentiel(%Residentiel{} = residentiel) do
    Repo.delete(residentiel)
  end

  @doc """
  Returns an `%Ecto.Changeset{}` for tracking residentiel changes.

  ## Examples

      iex> change_residentiel(residentiel)
      %Ecto.Changeset{source: %Residentiel{}}

  """
  def change_residentiel(%Residentiel{} = residentiel) do
    Residentiel.changeset(residentiel, %{})
  end

  alias Hydrosol.Soumission.ReCommercial

  @doc """
  Returns the list of commercials.

  ## Examples

      iex> list_commercials()
      [%ReCommercial{}, ...]

  """

  def list_commercials do
    Repo.all(Commercial)
  end

  @doc """
  Gets a single commercial.

  Raises `Ecto.NoResultsError` if the Commercial does not exist.

  ## Examples

      iex> get_commercial!(123)
      %Commercial{}

      iex> get_commercial!(456)
      ** (Ecto.NoResultsError)

  """
  def get_commercial!(id), do: Repo.get!(Commercial, id)

  @doc """
  Creates a commercial.

  ## Examples

      iex> create_commercial(%{field: value})
      {:ok, %Commercial{}}

      iex> create_commercial(%{field: bad_value})
      {:error, %Ecto.Changeset{}}

  """
  def create_commercial(attrs \\ %{}) do
    %Commercial{}
    |> Commercial.changeset(attrs)
    |> Repo.insert()
  end

  @doc """
  Updates a commercial.

  ## Examples

      iex> update_commercial(commercial, %{field: new_value})
      {:ok, %Commercial{}}

      iex> update_commercial(commercial, %{field: bad_value})
      {:error, %Ecto.Changeset{}}

  """
  def update_commercial(%Commercial{} = commercial, attrs) do
    commercial
    |> Commercial.changeset(attrs)
    |> Repo.update()
  end

  @doc """
  Deletes a Commercial.

  ## Examples

      iex> delete_commercial(commercial)
      {:ok, %Commercial{}}

      iex> delete_commercial(commercial)
      {:error, %Ecto.Changeset{}}

  """
  def delete_commercial(%Commercial{} = commercial) do
    Repo.delete(commercial)
  end

  @doc """
  Returns an `%Ecto.Changeset{}` for tracking commercial changes.

  ## Examples

      iex> change_commercial(commercial)
      %Ecto.Changeset{source: %Commercial{}}

  """
  def change_commercial(%Commercial{} = commercial) do
    Commercial.changeset(commercial, %{})
  end
end
