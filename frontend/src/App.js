import React, { useState, useEffect } from "react";
import axios from "axios";
import Page from "./components/Page";
import Sidebar from "./components/Sidebar";
import "./index.css";

const App = () => {
  const [pages, setPages] = useState([]);

  useEffect(() => {
    axios
      .get(`api/pages`)
      .then((res) => setPages(res.data))
      .catch((err) => console.log(err));
  }, []);

  return (
    <div class="flex min-h-screen">
      <Sidebar />
      <div class="flex flex-col w-full">
        <div class="text-white bg-blue-400 flex flex-shrink-0 flex-col">
          <div class="flex relative items-center p-4 h-12">
            <span class="text-2xl tracking-wide">Pages</span>
          </div>
        </div>
        {pages
          ? pages.map((page) => <Page key={page.id} pageId={page.id} />)
          : "no pages yet"}
      </div>
    </div>
  );
};

export default App;
