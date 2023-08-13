<template>
  <section class="p-6 mx-auto rounded-md shadow-md bg-gray-800">
    <h1 class="text-xl font-bold text-white capitalize dark:text-white">
      Agendamento de Vacinação
    </h1>
    <form>
      <div class="grid grid-cols-1 gap-6 mt-4 sm:grid-cols-2">
        <div>
          <label class="text-white dark:text-gray-200" for="passwordConfirmation"
            >Selecione o paciente</label
          >
          <select
            class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-300 rounded-md dark:bg-gray-800 dark:text-gray-300 dark:border-gray-600 focus:border-blue-500 dark:focus:border-blue-500 focus:outline-none focus:ring"
          >
            <option>Surabaya</option>
            <option>Jakarta</option>
            <option>Tangerang</option>
            <option>Bandung</option>
          </select>
        </div>
        <div>
          <label class="text-white dark:text-gray-200" for="passwordConfirmation"
            >Selecione a vacina</label
          >
          <select
            class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-300 rounded-md dark:bg-gray-800 dark:text-gray-300 dark:border-gray-600 focus:border-blue-500 dark:focus:border-blue-500 focus:outline-none focus:ring"
          >
            <option>Surabaya</option>
            <option>Jakarta</option>
            <option>Tangerang</option>
            <option>Bandung</option>
          </select>
        </div>
        <div>
          <label class="text-white dark:text-gray-200" for="passwordConfirmation"
            >Date</label
          >
          <input
            id="date"
            type="date"
            class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-300 rounded-md dark:bg-gray-800 dark:text-gray-300 dark:border-gray-600 focus:border-blue-500 dark:focus:border-blue-500 focus:outline-none focus:ring"
          />
        </div>

        <div>
          <label class="text-white dark:text-gray-200" for="passwordConfirmation"
            >Horário</label
          >
          <input
            id="time"
            type="time"
            class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-300 rounded-md dark:bg-gray-800 dark:text-gray-300 dark:border-gray-600 focus:border-blue-500 dark:focus:border-blue-500 focus:outline-none focus:ring"
          />
        </div>
      </div>

      <div class="flex justify-end mt-6">
        <a href="/agenda/listar" class="mx-2 text-white ">listar agendamentos</a>
        <button
          class="px-6 py-2 leading-5 text-white transition-colors duration-200 transform bg-blue-500 rounded-md hover:bg-blue-700 focus:outline-none focus:bg-gray-600"
        >
          Salvar
        </button>
      </div>
    </form>
  </section>
</template>
