import axios from "axios";
import React, { useState, useEffect } from "react";
import Modal from "react-modal";

const Sidebar = () => {
  const [modalIsOpen, setIsOpen] = useState(false);
  const [categories, setCategories] = useState([]);
  const [category, setCategory] = useState({});

  const url = "api/categories";

  const openModal = () => {
    setIsOpen(true);
  };

  const closeModal = () => {
    setIsOpen(false);
  };

  const handleSubmit = (evt) => {
    evt.preventDefault();
    axios
      .post(url, category)
      .then(fetchCategories())
      .catch((err) => console.log(err));
  };

  const fetchCategories = () => {
    axios
      .get(url)
      .then((res) => setCategories(res.data))
      .catch((err) => console.log(err));
  };

  useEffect(() => {
    fetchCategories();
  }, [categories]);

  return (
    <>
      <nav class="w-64 flex-shrink-0">
        <div class="flex-auto bg-gray-900 h-full">
          <div class="flex flex-col overflow-y-auto">
            <ul class="relative m-0 p-0 list-none h-full">
              <li class="p-4 w-full flex relative shadow-sm">
                <div class="flex-auto my-1">
                  <span class="text-white font-medium">Categories</span>
                </div>
              </li>
              {categories.map((c, index) => {
                return (
                  <div
                    key={index}
                    class="text-blue-400 flex relative px-4 hover:bg-gray-700 cursor-pointer"
                  >
                    <div class="flex-auto my-1">
                      <span key={index}>{c.name}</span>
                    </div>
                  </div>
                );
              })}
            </ul>
            <button onClick={openModal} className="text-gray-200">
              New Category
            </button>
          </div>
        </div>
      </nav>
      <div>
        <Modal
          isOpen={modalIsOpen}
          onRequestClose={closeModal}
          className="category-modal"
          contentLabel="Category Modal"
        >
          <div className="bg-white shadow-lg rounded px-12 pt-6 pb-8 mb-4">
            <button onClick={closeModal} className=" text-gray-400">
              x
            </button>
            <form onSubmit={handleSubmit}>
              <div class="text-gray-800 text-2xl flex justify-center border-b-2 py-2 mb-4">
                New Category
              </div>

              <div class="mb-4">
                <input
                  class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                  type="text"
                  value={category.name}
                  onChange={(e) => setCategory({ name: e.target.value })}
                  required
                  autofocus
                  placeholder="category name"
                />
              </div>

              <button
                class="px-4 py-2 rounded text-white shadow-lg bg-blue-500 hover:bg-blue-600 focus:bg-blue-700"
                type="submit"
              >
                Add Category
              </button>
            </form>
          </div>
        </Modal>
      </div>
    </>
  );
};

export default Sidebar;
