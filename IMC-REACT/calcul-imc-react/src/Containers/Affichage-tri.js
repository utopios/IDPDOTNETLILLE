import React, { Component } from "react";
import NavSide from "../Components/Navside";
import { LocalService } from "../services/LocalService";
import { get } from "../services/ApiService";
import { Table, Input, Button, Space } from "antd";
import Highlighter from "react-highlight-words";
import { SearchOutlined } from "@ant-design/icons";
import "../index.css";
import Chart from "react-google-charts";
import { Spin } from 'antd';
import { LoadingOutlined } from '@ant-design/icons';

class AffichageTri extends Component {
  constructor(props) {
    super(props);
    this.state = {
      userActuel: undefined,
      listImcBrut: [],
      listImcFinal: [],
      data: []
    };
  }

  componentDidMount() {
    const user = JSON.parse(localStorage.getItem('user'));
    const userNom = user.nom;
    this.setState({
      userActuel: userNom
    });
    this.appelList(user.nom);
  }

  appelList = user => {
    get("listImcUser/" + user).then(res => {
      this.setState({
        listImcBrut: res.data
      });
      this.modificationTableauTri();
    });
  };

  modificationTableauTri = () => {
    const tabMois = [];
    const tab = this.state.listImcBrut;
    console.log(tab);
    const tableau = tab.reverse();
    if (tableau.length > 89) {
      for (let i = 0; i < 90; i++) {
        let jour = tableau[i];
        tabMois.push(jour);
      }
      this.setState({
        listImcFinal: tabMois
      });
    } else {
      this.setState({
        listImcFinal: tableau
      });
    }
    this.calculDataPie();
  };

  calculDataPie = () => {
    let compteurMaigre = 0;
    let compteurNormal = 0;
    let compteurSurpoids = 0;
    let compteurObesite = 0;
    let compteurMorbide = 0;

    for (let imc of this.state.listImcFinal) {
      switch (imc.etat) {
        case "Maigreur": {
          compteurMaigre++;
        }
        case "Normal": {
          compteurNormal++;
        }
        case "Surpoids": {
          compteurSurpoids++;
        }
        case "Obésité": {
          compteurObesite++;
        }
        case "O.Morbide": {
          compteurMorbide++;
        }
          // if (imc.etat == "Maigreur") {
          //   compteurMaigre++;
          // } else if (imc.etat == "Normal") {
          //   compteurNormal++;
          // } else if (imc.etat == "Surpoids") {
          //   compteurSurpoids++;
          // } else if (imc.etat == "Obésité") {
          //   compteurObesite++;
          // } else if (imc.etat == "O.Morbide") {
          //   compteurMorbide++;
          // }
      }
    }

      const dataPie = [
        ["Etat", "Valeur"],
        ["Maigreur", compteurMaigre],
        ["Normal", compteurNormal],
        ["Surpoids", compteurSurpoids],
        ["Obésité", compteurObesite],
        ["O.Morbide", compteurMorbide]
      ];

      this.setState({
        data: dataPie
      });
      console.log(this.state.data);
    };

    getColumnSearchProps = dataIndex => ({
      filterDropdown: ({
        setSelectedKeys,
        selectedKeys,
        confirm,
        clearFilters
      }) => (
        <div style={{ padding: 8 }}>
          <Input
            ref={node => {
              this.searchInput = node;
            }}
            placeholder={`Search ${dataIndex}`}
            value={selectedKeys[0]}
            onChange={e =>
              setSelectedKeys(e.target.value ? [e.target.value] : [])
            }
            onPressEnter={() =>
              this.handleSearch(selectedKeys, confirm, dataIndex)
            }
            style={{ width: 188, marginBottom: 8, display: "block" }}
          />
          <Space>
            <Button
              type="primary"
              onClick={() => this.handleSearch(selectedKeys, confirm, dataIndex)}
              icon={<SearchOutlined />}
              size="small"
              style={{ width: 90 }}
            >
              Search
            </Button>
            <Button
              onClick={() => this.handleReset(clearFilters)}
              size="small"
              style={{ width: 90 }}
            >
              Reset
            </Button>
          </Space>
        </div>
      ),
      filterIcon: filtered => (
        <SearchOutlined style={{ color: filtered ? "#1890ff" : undefined }} />
      ),
      onFilter: (value, record) =>
        record[dataIndex]
          ? record[dataIndex]
            .toString()
            .toLowerCase()
            .includes(value.toLowerCase())
          : "",
      onFilterDropdownVisibleChange: visible => {
        if (visible) {
          setTimeout(() => this.searchInput.select());
        }
      },
      render: text =>
        this.state.searchedColumn === dataIndex ? (
          <Highlighter
            highlightStyle={{ backgroundColor: "#ffc069", padding: 0 }}
            searchWords={[this.state.searchText]}
            autoEscape
            textToHighlight={text ? text.toString() : ""}
          />
        ) : (
          text
        )
    });

    handleSearch = (selectedKeys, confirm, dataIndex) => {
      confirm();
      this.setState({
        searchText: selectedKeys[0],
        searchedColumn: dataIndex
      });
    };

    handleReset = clearFilters => {
      clearFilters();
      this.setState({ searchText: "" });
    };

    render() {
      const antIcon = <LoadingOutlined style={{ fontSize: 24 }} spin />;
      const columns = [
        {
          title: "Date",
          dataIndex: "date",
          key: "date",
          width: "30%",
          ...this.getColumnSearchProps("date")
        },
        {
          title: "Poids",
          dataIndex: "poids",
          key: "poids",
          width: "20%",
          ...this.getColumnSearchProps("poids")
        },
        {
          title: "Indice",
          dataIndex: "indice",
          key: "indice",
          ...this.getColumnSearchProps("indice")
        },
        {
          title: "Etat",
          dataIndex: "etat",
          key: "etat",
          ...this.getColumnSearchProps("etat")
        }
      ];
      return (
        <div className="home">
          <NavSide></NavSide>
          <div className="container-fluid form">
            <div className="row m-t-25">
              <div className="col-6 mr-10">
                <Table
                  columns={columns}
                  rowClassName={(record, index) =>
                    record.etat == "Normal"
                      ? "table-row-normal"
                      : "table-row-dark" && record.etat == "Surpoids"
                        ? "table-row-surpoid"
                        : "table-row-dark" && record.etat == "Maigreur"
                          ? "table-row-maigreur"
                          : "table-row-dark" && record.etat == "Obésité"
                            ? "table-row-obesite"
                            : "table-row-dark" && record.etat == "O.Morbide"
                              ? "table-row-morbide"
                              : "table-row-dark"
                  }
                  dataSource={this.state.listImcFinal}
                />
              </div>
              <Chart
                className="ml4"
                width={"500px"}
                height={"300px"}
                chartType="PieChart"
                loader={<Spin indicator={antIcon} />}
                data={this.state.data}
                options={{
                  title: "Repartition en durée IMC sur 90 jours"
                }}
                rootProps={{ "data-testid": "1" }}
              />
            </div>
          </div>
        </div>
      );
    }
  }
export default AffichageTri;
